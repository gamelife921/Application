//LED
const int ledPin =10;
//온도
float temp;
//조도
const int sunPin=A1;
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
       //inValue 값이 1이 나오면 LED 는 ON으로 나타 낸다
       if(inValue=='1'){
          digitalWrite(ledPin,HIGH);
          Serial.println("LED:ON");
        //inValue 값이 1이 아닐 경우 else if 로 넘어가 값이 0이면 LED 는 OFF으로 나타 낸다
       }else if(inValue=='0'){
          digitalWrite(ledPin,LOW);
          Serial.println("LED:OFF");
       }
  }
  
  //온도
  //A0 을 int로 선언한다
  int val = analogRead(A0);
  //화씨 → 섭씨 변경
  temp = val*0.48828125; 
  //온도 값을 출력한다 
  Serial.print("TEMP:");
  Serial.println(temp);

  //조도
  //sunPind은 sunValue 이고 int로 선언을 했다
  int sunValue = analogRead(sunPin);
  //조도 값을 출력한다
  Serial.print("SUN:");
  Serial.println(sunValue);
  //ledPin 밝기를 조절한다
  analogWrite(ledPin, sunValue/4);
  
  //초음파
  //trig_pin 는 OFF
  digitalWrite(trig_pin,LOW);
  //초음파 발사 지연을 0.000002초 정도 실행을 중지한다
  delayMicroseconds(2);
  //trig_pin 는 ON
  digitalWrite(trig_pin,HIGH);
  //초음파 발사 지연을 0.00001초 정도 실행을 중지한다
  delayMicroseconds(10);
  //trig_pin 는 OFF
  digitalWrite(trig_pin,LOW);

  //echo_pin 는 duration 이며 실수로 나타낸다
  long duration = pulseIn(echo_pin,HIGH);
  //duration 는 distance 이며 실수로 나타낸다
  long distance = (duration/2)/29.1;

  //초음파 를 출력한다
  Serial.print("DIS:");
  Serial.println(distance);
  Serial.println(" ");
  

  //0.5초 간격으로 속도를 지연 시킨다
  delay(500);
}