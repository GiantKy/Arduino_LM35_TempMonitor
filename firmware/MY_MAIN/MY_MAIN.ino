

//khai bao bien toan cuc
int adc[2];
float Tam;
byte NhietDo[2];
char Chuoi[20];

/*
  SerialEvent occurs whenever a new data comes in the hardware serial RX. This
  routine is run between each time loop() runs, so using delay inside loop can
  delay response. Multiple bytes of data may be available.
*/
void serialEvent() 
{
  while (Serial.available()) 
  {
    // get the new byte:
    char inChar = (char)Serial.read();
  
    // do something about it:
    if (inChar != '\n')
    {
      
    }
  }
}

void setup()
{
  // put your setup code here, to run once:

  Serial.begin(9600); delay(100);
  
}

void loop()
{
  // put your main code here, to run repeatedly:
  /*
   * ta co: cu 1023[adc] thi tuong ung 5000mv
   * vay  voi adc thi tuong ung bao nhieu a mv?  
   * => a = (adc * 5000)/1023
   * theo datasheet ta co:
   * cu  10mv thi tuong ung 1 do C
   * vay (adc * 5000)/1023 thi tuong ung b do C
   * => b = (adc * 5000)/1023/10 = (adc*500)/1023
   */

  adc[0] = analogRead(A0);
  Tam =  (adc[0]*500.0)/1023.0; 
  NhietDo[0] = Tam;
  
  adc[1] = analogRead(A1);
  Tam =  (adc[1]*500.0)/1023.0; 
  NhietDo[1] = Tam;  
  
  sprintf(Chuoi,"%d,%d\n",NhietDo[0],NhietDo[1]);
  Serial.print(Chuoi);
  delay(100);
   

}
