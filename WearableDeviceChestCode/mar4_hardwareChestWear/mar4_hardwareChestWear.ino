//--------------------------------------------------------------------------------------
//MainChestHardware
//Group#3_mainChest_Version_4
//
//Description
//The ChestWear will have the following sensors to send to a packet
//1) Button Data
//2) accelerometer Data
//3) Heart rate data(BPM)
//4) Packet transmission
//5) Bluetooth trnsmission(later)
//--------------------------------------------------------------------------------------

#include <Wire.h>
#include <ADXL345.h>

ADXL345 adxl; //variable adxl is an instance of the ADXL345 library
//--------------------------------------------------------------------------------------
//Heart Rate variable declaration
//--------------------------------------------------------------------------------------
#define HRMI_I2C_ADDR      127
#define HRMI_HR_ALG        1   // 1= average sample, 0 = raw sample

//--------------------------------------------------------------------------------------
// Button variable declaration
//--------------------------------------------------------------------------------------
#define interrupt_pin 9 //Define Analog Pin
int ledPin = 8; //digital output pin 8
volatile int buttonStat = 0; //state of the button based on interrupts

int accelerometer_reading; // a number for what freefall, inactivity, etc 0) freefall,1 inactivity,2 activity,3 double tap,4 tap
 

void setup(){  
   
//--------------------------------------------------------------------------------------
// Heart Rate Setup
//--------------------------------------------------------------------------------------  
  setupHeartMonitor(HRMI_HR_ALG);
  Serial.begin(9600);
  //mySerial.begin(9600);
  
//--------------------------------------------------------------------------------------
// Emergency Interrupt Button Setup
//--------------------------------------------------------------------------------------  
/* Pin to interrupt map:
* D0-D7 = PCINT 16-23 = PCIE2 = pcmsk2
* D8-D13 = PCINT 0-5 = PCIE0 = pcmsk0
* A0-A5 (D14-D19) = PCINT 8-13 = PCIE1 = pcmsk1 */
PCICR |= (1<<PCIE2); //interrupt enable 
PCMSK2 |= (1<<PCINT23); //interrupt mask
MCUCR = (1<<ISC00) | (1<<ISC01); // falling edge now......00  low level  , 01 any change  , 10  falling edge  , 11 rising edge
  
pinMode(ledPin, OUTPUT); //LED Output
pinMode(interrupt_pin, INPUT);  //interrupt pin an input
digitalWrite(interrupt_pin,HIGH);   //Enable pullup resistor on Analog Pin
buttonStat = 0;
interrupts(); //interrupts are running 

//--------------------------------------------------------------------------------------
// Accelerometer Button Setup
//--------------------------------------------------------------------------------------  
  adxl.powerOn();
  //set activity/ inactivity thresholds (0-255)
  adxl.setActivityThreshold(75); //62.5mg per increment
  adxl.setInactivityThreshold(75); //62.5mg per increment
  adxl.setTimeInactivity(10); // how many seconds of no activity is inactive? 
  //look of activity movement on this axes - 1 == on; 0 == off 
  adxl.setActivityX(1);
  adxl.setActivityY(1);
  adxl.setActivityZ(1); 
  //look of inactivity movement on this axes - 1 == on; 0 == off
  adxl.setInactivityX(1);
  adxl.setInactivityY(1);
  adxl.setInactivityZ(1); 
  //look of tap movement on this axes - 1 == on; 0 == off
  adxl.setTapDetectionOnX(0);
  adxl.setTapDetectionOnY(0);
  adxl.setTapDetectionOnZ(1); 
  //set values for what is a tap, and what is a double tap (0-255)
  adxl.setTapThreshold(50); //62.5mg per increment
  adxl.setTapDuration(15); //625μs per increment
  adxl.setDoubleTapLatency(80); //1.25ms per increment
  adxl.setDoubleTapWindow(200); //1.25ms per increment
  //set values for what is considered freefall (0-255)
  adxl.setFreeFallThreshold(7); //(5 - 9) recommended - 62.5mg per increment
  adxl.setFreeFallDuration(45); //(20 - 70) recommended - 5ms per increment 
  //setting all interupts to take place on int pin 1
  //I had issues with int pin 2, was unable to reset it
  adxl.setInterruptMapping( ADXL345_INT_SINGLE_TAP_BIT,   ADXL345_INT1_PIN );
  adxl.setInterruptMapping( ADXL345_INT_DOUBLE_TAP_BIT,   ADXL345_INT1_PIN );
  adxl.setInterruptMapping( ADXL345_INT_FREE_FALL_BIT,    ADXL345_INT1_PIN );
  adxl.setInterruptMapping( ADXL345_INT_ACTIVITY_BIT,     ADXL345_INT1_PIN );
  adxl.setInterruptMapping( ADXL345_INT_INACTIVITY_BIT,   ADXL345_INT1_PIN ); 
  //register interupt actions - 1 == on; 0 == off  
  adxl.setInterrupt( ADXL345_INT_SINGLE_TAP_BIT, 1);
  adxl.setInterrupt( ADXL345_INT_DOUBLE_TAP_BIT, 1);
  adxl.setInterrupt( ADXL345_INT_FREE_FALL_BIT,  1);
  adxl.setInterrupt( ADXL345_INT_ACTIVITY_BIT,   1);
  adxl.setInterrupt( ADXL345_INT_INACTIVITY_BIT, 1);
}

void loop(){
  
  //Boring accelerometer stuff   
  int x,y,z;  
  adxl.readAccel(&x, &y, &z); //read the accelerometer values and store them in variables  x,y,z
  //int accelerometer_reading; // a number for what freefall, inactivity, etc 0) freefall,1 inactivity,2 activity,3 double tap,4 tap
 
  //getInterruptSource clears all triggered actions after returning value
  //so do not call again until you need to recheck for triggered actions
   byte interrupts = adxl.getInterruptSource();
  
  // freefall
  if(adxl.triggered(interrupts, ADXL345_FREE_FALL)){
    Serial.println("freefall");
    accelerometer_reading = 0;
    //add code here to do when freefall is sensed
  }   
  //inactivity
  if(adxl.triggered(interrupts, ADXL345_INACTIVITY)){
    Serial.println("inactivity");
    accelerometer_reading = 1;
     //add code here to do when inactivity is sensed
  }  
  //activity
  if(adxl.triggered(interrupts, ADXL345_ACTIVITY)){
    Serial.println("activity"); 
    accelerometer_reading = 2;
     //add code here to do when activity is sensed
  }  
  //double tap
  if(adxl.triggered(interrupts, ADXL345_DOUBLE_TAP)){
    Serial.println("double tap");
    accelerometer_reading = 3;
     //add code here to do when a 2X tap is sensed
  }
    //tap
  if(adxl.triggered(interrupts, ADXL345_SINGLE_TAP)){
    Serial.println("tap");
    accelerometer_reading= 4;
     //add code here to do when a tap is sensed
  } 
  
  
  int heartRate = getHeartRate(); //get heart rate in BPM
  //getEmergencyButton(buttonStat); //get emergency button readings  
  
  sendPacket(heartRate); //send the packet of data to PC
  delay(800);
}

//--------------------------------------------------------------------------------------
// Interrupt Service Routine for Button 
//-------------------------------------------------------------------------------------- 
ISR(PCINT2_vect) { //PCINT2_vect is for pin 7
  buttonStat = 1; 
  digitalWrite(ledPin, HIGH);
  
}

//--------------------------------------------------------------------------------------
// Emergency Button Function
//-------------------------------------------------------------------------------------- 
/*void getEmergencyButton (int buttonStat)
{
  if (buttonStat == 1){
     digitalWrite(ledPin, HIGH);
     buttonStat = 0; //set back to zero
  }
  else
  {
    digitalWrite(ledPin, LOW);
  }
}
*/
//--------------------------------------------------------------------------------------
// Packet Function
//-------------------------------------------------------------------------------------- 
void sendPacket(int heartRate)
{
    int p_data[4];
    p_data[0] = accelerometer_reading;
    p_data[1] = buttonStat;
    p_data[2] = heartRate;
    p_data[3] = (p_data[0]+ p_data[1] + p_data[2] + p_data[3]) & 0x7f; //check sum bit
    //Serial.write(p_data, sizeof(p_data));
    //Serial.println('\n');
    Serial.print("ACC");
    Serial.print(p_data[0], DEC);
    Serial.print("H");
    Serial.print(p_data[2], DEC);
    Serial.print("B");
    Serial.print(p_data[1], DEC);
    //Serial.print(""); // 9 characters
}

//--------------------------------------------------------------------------------------
// Setup Heart Monitor Function
//-------------------------------------------------------------------------------------- 
void setupHeartMonitor(int type){
  //setup the heartrate monitor
  Wire.begin();
  writeRegister(HRMI_I2C_ADDR, 0x53, type); // Configure the HRMI with the requested algorithm mode
}

//--------------------------------------------------------------------------------------
// Acquire Heart Rate Function
//-------------------------------------------------------------------------------------- 
int getHeartRate(){
  //get and return heart rate
  //returns 0 if we couldnt get the heart rate
  byte i2cRspArray[3]; // I2C response array
  i2cRspArray[2] = 0;
  int noBeat = 0;

  writeRegister(HRMI_I2C_ADDR,  0x47, 0x1); // Request a set of heart rate values 

  if (hrmiGetData(127, 3, i2cRspArray)) {
    noBeat = ((i2cRspArray[0] & (1 << 2-1)) != 0);
    if (noBeat == 1) return 0;
    return i2cRspArray[2];
  }
  else{
    return 0;
  }
}
//--------------------------------------------------------------------------------------
// Write Register Function
//-------------------------------------------------------------------------------------- 
void writeRegister(int deviceAddress, byte address, byte val) {
  //I2C command to send data to a specific address on the device
  Wire.beginTransmission(deviceAddress); // start transmission to device 
  Wire.write(address);       // send register address
  Wire.write(val);         // send value to write
  Wire.endTransmission();     // end transmission
}
//--------------------------------------------------------------------------------------
// HRMI getData Function
//-------------------------------------------------------------------------------------- 
boolean hrmiGetData(byte addr, byte numBytes, byte* dataArray){
  //Get data from heart rate monitor and fill dataArray byte with responce
  //Returns true if it was able to get it, false if not
  Wire.requestFrom(addr, numBytes);
  if (Wire.available()) {

    for (int i=0; i<numBytes; i++){
      dataArray[i] = Wire.read();
    }
    return true;
  }
  else{
    return false;
  }
}

