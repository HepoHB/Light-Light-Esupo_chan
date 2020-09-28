char estado = '0';
const int LED = 14;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);

}

void loop() {
  // put your main code here, to run repeatedly:

  if (Serial.available() > 0) { 
     estado = Serial.read();
  }
  if (estado == '1'){ 
     digitalWrite(LED, HIGH);
  }
  if (estado == '0'){ 
     digitalWrite(LED, LOW);
  }
}
