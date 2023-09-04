//LED
const int ledPin =9;
//온도
float temp;
//조도
const int sunPin=A2;
//초음파
const int trig_pin = 11;
const int echo_pin = 12;

void setup() {
  Serial.begin(9600); //BPS 값(Bits Per Seconds)
  //LED
  pinMode(ledPin,OUTPUT);

    //초음파
  pinMode(trig_pin,OUTPUT);
  pinMode(echo_pin,INPUT);
}

void loop() {
  //LED
  if(Serial.available()){
       char inValue = Serial.read();
       if(inValue=='1'){
          digitalWrite(ledPin,HIGH);
          Serial.println("LED:ON");
       }else if(inValue=='0'){
          digitalWrite(ledPin,LOW);
          Serial.println("LED:OFF");
       }
  }
  
  //온도
  int val = analogRead(A0);
  temp = val*0.48828125; //화씨 → 섭씨 변경
  Serial.print("TEMP:");
  Serial.println(temp);

  //조도
  int sunValue = analogRead(sunPin);
  Serial.print("SUN:");
  Serial.println(sunValue);
  analogWrite(ledPin, sunValue/4);
  
  //초음파
  digitalWrite(trig_pin,LOW);
  delayMicroseconds(2);
  digitalWrite(trig_pin,HIGH);
  delayMicroseconds(10);
  digitalWrite(trig_pin,LOW);

  long duration = pulseIn(echo_pin,HIGH);
  long distance = (duration/2)/29.1;

  Serial.print("DIS:");
  Serial.println(distance);
  Serial.println(" ");
  
  delay(500);
}