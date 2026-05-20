int buttonState1 = 0;
int buttonState2 = 0;

void setup() {

  pinMode(1, INPUT);
  pinMode(2, INPUT);
  pinMode(3, OUTPUT);
  pinMode(LED_BUILTIN, OUTPUT);
}
void loop()
{
  buttonState1 = digitalRead(1);
  buttonState2 = digitalRead(2);

  if (buttonState1 == HIGH) {
    digitalWrite(3, HIGH);
  }
  
  if (buttonState2 == HIGH){
    digitalWrite(3, LOW);
  }
}  