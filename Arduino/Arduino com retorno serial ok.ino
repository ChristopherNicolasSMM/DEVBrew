#include <SoftwareSerial.h>   //Inlcui a biblioteca SoftwareSerial.h

byte p_ana[6]  = {'A0', 'A1', 'A2', 'A3', 'A4', 'A5'};

byte p_dig[14] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

int n_loop = 0;

void setup() {
  Serial.begin(9600);    //configura comunicação serial com 9600 bps

  for (int nD = 0; nD < 13; nD++) {
    pinMode(p_dig[nD], OUTPUT);
  }

  for (int nA = 0; nA <= 5; nA++) {
    pinMode(p_ana[nA], OUTPUT);
  }

}
void loop() {
  delay(1000);
  n_loop ++;
  Serial.println(n_loop);
  
  for (int nA = 0; nA <= 5; nA++) {
    delay(1000);
    Serial.print("Porta analogica: ");
    Serial.print(nA);
    Serial.print(" valor: ");
    Serial.println(analogRead(p_ana[nA]));
  }
  
  for (int nD = 0; nD <= 13; nD++) {
    getSerial();
    delay(1000);
    Serial.print("Porta digital  : ");
    Serial.print(nD);
    Serial.print(" valor:  ");
    Serial.println(digitalRead(p_dig[nD]));
  }
}

void getSerial()
{
  if (Serial.available()) 
  {
    switch (Serial.read())   
    {
      case 'A':       
      //  digitalWrite(1, !digitalRead(1));
      case 'B':       
        digitalWrite(2, !digitalRead(2));
      case 'C':       
        digitalWrite(3, !digitalRead(3));
      case 'D':       
        digitalWrite(4, !digitalRead(4));
      case 'E':       
        digitalWrite(5, !digitalRead(5));
      case 'F':       
        digitalWrite(6, !digitalRead(6));  
      case 'G':       
        digitalWrite(7, !digitalRead(7));
      case 'H':       
        digitalWrite(8, !digitalRead(8));
      case 'I':       
        digitalWrite(9, !digitalRead(9));
      case 'J':       
        digitalWrite(10, !digitalRead(10));
      case 'L':       
        digitalWrite(11, !digitalRead(11));
      case 'M':       
        digitalWrite(12, !digitalRead(12));    
      case 'N':       
       // digitalWrite(13, !digitalRead(13));         
      break;
    }
  }
}