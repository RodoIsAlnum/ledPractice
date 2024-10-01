int ledPin = 13;

void setup() {
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if (Serial.available() > 0)
  {
    char data = Serial.read();
    if (data == 'b') {digitalWrite(ledPin, HIGH);}
    else if (data == 'a') {digitalWrite(ledPin, LOW);} 
  }
}