/*
 * Du an: Doc nhiet do LM35 va gui qua Serial
 * Mon: Mang Cam Bien - Tuan 03
 */

int adcValue;
float nhietDo;

void setup() {
  Serial.begin(9600);
  delay(100);
}

void loop() {
  adcValue = analogRead(A0);
  nhietDo = (adcValue * 500.0) / 1023.0;
  Serial.println(nhietDo, 1);
  delay(1000);
}