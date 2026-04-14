/*
 * Du an: Doc nhiet do LM35 va gui qua Serial
 * Mon: Mang Cam Bien - Tuan 03
 */

int adcValues[2]; float nhietDo[2]; char chuoi[30];

void setup() {
  Serial.begin(9600);
  delay(100);
}


void loop() {
  adcValues[0] = analogRead(A0);
  nhietDo[0] = (adcValues[0] * 500.0) / 1023.0;
  adcValues[1] = analogRead(A1);
  nhietDo[1] = (adcValues[1] * 500.0) / 1023.0;
   adcValues[2] = analogRead(A2);
  nhietDo[2] = (adcValues[2] * 500.0) / 1023.0;
  sprintf(chuoi, "%d,%d\n", (int)nhietDo[0], (int)nhietDo[1]);
  Serial.print(chuoi);
  delay(100);
}