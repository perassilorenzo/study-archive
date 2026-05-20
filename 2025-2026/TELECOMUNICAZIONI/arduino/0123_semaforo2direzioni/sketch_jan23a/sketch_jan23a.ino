void setup() {
  // put your setup code here, to run once:
  pinMode(2, OUTPUT); //verde1
  pinMode(5, OUTPUT); //verde2
  pinMode(3, OUTPUT); //giallo1
  pinMode(6, OUTPUT); //giallo2
  pinMode(4, OUTPUT); //rosso1
  pinMode(7, OUTPUT); //rosso2
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(2, HIGH);
  digitalWrite(7, HIGH);
  delay(5000);
  digitalWrite(2, LOW);
  
  digitalWrite(3, HIGH);
  delay(5000);
  digitalWrite(3, LOW);
  digitalWrite(7, LOW);

  digitalWrite(4, HIGH);
  digitalWrite(6, HIGH);
  delay(5000);
  digitalWrite(6, LOW);

  digitalWrite(5, HIGH);
  delay(5000);
  digitalWrite(5, LOW);
  digitalWrite(4, LOW);


}
