#include <string.h>
#include <AccelStepper.h>
// Driver (13 - step, 12 - direction)
// низ правый
AccelStepper stepper1(AccelStepper::DRIVER, 2, 22);
// низ левый
AccelStepper stepper2(AccelStepper::DRIVER, 3, 25);
// верх правый
AccelStepper stepper3(AccelStepper::DRIVER, 4, 35);
// верх левый
AccelStepper stepper4(AccelStepper::DRIVER, 5, 45);
// дальний левый
AccelStepper stepper5(AccelStepper::DRIVER, 6, 49);
// дальний правый
AccelStepper stepper6(AccelStepper::DRIVER, 7, 52);
char buffer[11];
//передаваемые параметры
int d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12;
int on1 = 0;
int on2 = 0;
int on3 = 0;
int on4 = 0;
int on5 = 0;
int on6 = 0;
int endMove1 = 0;
int endMove2 = 0;
int endMove3 = 0;
int endMove4 = 0;
int endMove5 = 0;
int endMove6 = 0;
void setup()
{ 
  /*
  stepper.setMaxSpeed(1750);
  stepper.setAcceleration(1000);*/
  Serial.begin(115200);
}

void loop(){
  int i=0;
  char buffer[100];
  if(Serial.available()){
    //задержка для получения данных
    delay(50);
    //загоняем прочитанное в буфер
    while( Serial.available() && i< 99) {
      buffer[i++] = Serial.read();
    }
    //закрываем массив
    buffer[i++]='\0';
    on1 = 1;
    on2 = 1;
    on3 = 1;
    on4 = 1;
    on5 = 1;
    on6 = 1;
  }
  //если буфер наполнен разбор буффера
  if(i>0){
    d1=atoi(strtok(buffer," "));
    d2=atoi(strtok(NULL," "));
    d3=atoi(strtok(NULL," "));
    d4=atoi(strtok(NULL," "));
    d5=atoi(strtok(NULL," "));
    d6=atoi(strtok(NULL," "));
    d7=atoi(strtok(NULL," "));
    d8=atoi(strtok(NULL," "));
    d9=atoi(strtok(NULL," "));
    d10=atoi(strtok(NULL," "));
    d11=atoi(strtok(NULL," "));
    d12=atoi(strtok(NULL," "));
  }
  
  //Serial.println(d3);
  stepper1.setMaxSpeed(d1);
  stepper1.setAcceleration(6000);
  stepper1.moveTo(d2);
  stepper2.setMaxSpeed(d3);
  stepper2.setAcceleration(6000);
  stepper2.moveTo(d4);
  stepper3.setMaxSpeed(d5);
  stepper3.setAcceleration(6000);
  stepper3.moveTo(d6);
  stepper4.setMaxSpeed(d7);
  stepper4.setAcceleration(6000);
  stepper4.moveTo(d8);
  stepper5.setMaxSpeed(d9);
  stepper5.setAcceleration(6000);
  stepper5.moveTo(-d10);
  stepper6.setMaxSpeed(d11);
  stepper6.setAcceleration(6000);
  stepper6.moveTo(-d12);

  /*
  //условие движения пока не достигнута нужная дистанция
  while (stepper1.distanceToGo() != 0 && stepper2.distanceToGo() != 0) {
    //Serial.println(stepper.currentPosition());
    stepper1.run();
    stepper2.run();
  }
    */
    /*while(stepper1.distanceToGo() == 0 && stepper2.distanceToGo() == 0){
      Serial.print(2);
    }
    if(stepper1.currentPosition() == stepper1.targetPosition()){
     Serial.println(2); 
    }
    */
    stepper1.run();
    stepper2.run();
    stepper3.run();
    stepper4.run();
    stepper5.run();
    stepper6.run();
    
      // Change direction at the limits
    if (stepper1.distanceToGo() == 0 && on1 == 1){
      //stepper1.moveTo(stepper1.currentPosition());
      endMove1 = 1;
      //Serial.println(d2);
      on1 = 0;
    }
    if (stepper2.distanceToGo() == 0 && on2 == 1){
      //stepper2.moveTo(stepper2.currentPosition());
      endMove2 = 1;
      //Serial.println(d4);
      on2 = 0;
    }
    if (stepper3.distanceToGo() == 0 && on3 == 1){
      //stepper3.moveTo(stepper3.currentPosition());
      endMove3 = 1;
      //Serial.println(d6);
      on3 = 0;
    }
    if (stepper4.distanceToGo() == 0 && on4 == 1){
      //stepper4.moveTo(stepper4.currentPosition());
      endMove4 = 1;
      //Serial.println(d8);
      on4 = 0;
    }
    if (stepper5.distanceToGo() == 0 && on5 == 1){
      //stepper5.moveTo(stepper5.currentPosition());
      endMove5 = 1;
      //Serial.println(d10);
      on5 = 0;
    }
    if (stepper6.distanceToGo() == 0 && on6 == 1){
      //stepper6.moveTo(stepper6.currentPosition());
      endMove6 = 1;
      //Serial.println(d12);
      on6 = 0;
    }

    if(endMove1 == 1 && endMove2 == 1 && endMove3 == 1 && endMove4 == 1 && endMove5 == 1 && endMove6 == 1){
      Serial.println(1);
      endMove1 = 0;
      endMove2 = 0;
      endMove3 = 0;
      endMove4 = 0;
      endMove5 = 0;
      endMove6 = 0;
    }
    /*
    if (stepper1.distanceToGo() == 0){
      Serial.println(1);
    }else{
       Serial.println(2);
     }*/
}
