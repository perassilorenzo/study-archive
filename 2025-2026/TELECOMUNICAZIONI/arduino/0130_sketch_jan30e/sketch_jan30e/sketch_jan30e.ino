int ledState = 0;
int lastState = 0;

void setup() {
    pinMode(1, INPUT);
    pinMode(3, OUTPUT);
}

void loop() {
    int buttonState = digitalRead(1);

    if (buttonState == HIGH && lastState == LOW) {
        ledState = !ledState;
    }

    digitalWrite(3, led);
    lastState = buttonState;
    delay(50);
}