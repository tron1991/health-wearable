//Relay System for Appliance Control
//Group 3

//Purpose of the program is to control two appliances with voice control



#define relayOne 7   //relay connector 1
#define relayTwo 9  // relay connector 2

int relayPinTwo = 0;

long relayTwoTimer=0;
int incomingByte = 0;
int dataInbound = 0;


void setup()
{
Serial.begin(9600);
pinMode(relayOne, OUTPUT);
pinMode(relayTwo, OUTPUT);

digitalWrite(relayOne, HIGH); //turns the relay1 off initially
digitalWrite(relayTwo, HIGH); //turns the relay2 off initially
}

void loop()
{ 
  // if (Serial.available() > 0) {
  // read the incoming byte:
  //   getBTData(); }
  
  //the above is for Serial Communication
  
     getBTData();
     updateRelays();
     actuallyUpdateRelays();
     delay(1000);
}

void getBTData() {
        
        // read the incoming byte:
        //incomingByte = Serial.read();
        incomingByte = 6;
        dataInbound = incomingByte;
        //A simple packet to be sent to this microcontroller
}

void updateRelays() { // for updating the relay...if no command or task is given keep at the relay
	if (dataInbound==0) {   //Do nothing
                  delay(1000);}
	else if (dataInbound==1){
                  digitalWrite(relayOne, LOW);
                  delay(1000); } //Enable relay one
	else if (dataInbound==2) {
                  digitalWrite(relayOne, HIGH); //off
                  delay(1000);}
	else if (dataInbound==3) {
                  digitalWrite(relayTwo, LOW); //on
                  relayPinTwo = 0;
                  delay(1000);}
	else if (dataInbound==4) {
                  digitalWrite(relayTwo, HIGH);  //off
                  relayPinTwo = 1;
                  delay(1000);}
	else if (dataInbound==5){ //Both off for emergnecy situations
		  digitalWrite(relayOne, HIGH); //off
		  digitalWrite(relayTwo, HIGH);
                  relayPinTwo = 1;
                  delay(1000);}
        else if (dataInbound==6){ //Both on
		  digitalWrite(relayOne, LOW); //on
		  digitalWrite(relayTwo, LOW);
                  relayPinTwo = 0;
                  delay(1000);
        
	}
}
void actuallyUpdateRelays()
{
	if (relayPinTwo == 0){
		//update relay	
		relayTwoTimer++;
		if (relayTwoTimer>=5) { //this shuts off both appliances after 10 seconds of function...later design, will shut off
			digitalWrite(relayTwo, HIGH);
			relayTwoTimer=0;
                        //dataInbound=0;
		 }
	      }
         else if (relayPinTwo == 1) 
        {
             relayTwoTimer=0;
        }
}
   
  

