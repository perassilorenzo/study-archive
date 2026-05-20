void setup() {

  pinMode(3, INPUT);
  pinMode(13, OUTPUT);
  pinMode(2, INPUT);
  pinMode(8, OUTPUT);

}

void loop() {
  digitalWrite(8, digitalRead(3));
  digitalWrite(13, digitalRead(2));
}
