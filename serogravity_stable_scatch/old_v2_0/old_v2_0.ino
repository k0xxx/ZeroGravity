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
int dist1, dist2, dist3, dist4, dist5, dist6, endtime;
int stepDist1, stepDist2, stepDist3, stepDist4, stepDist5, stepDist6;
int calcSpeed1, calcSpeed2, calcSpeed3, calcSpeed4, calcSpeed5, calcSpeed6;
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
void setup(){
  Serial.begin(115200);
}

void loop(){
	int i=0;
	char buffer[100];
	if(Serial.available()){
		// Задержка для получения данных
		delay(200);
		// Цикл наполнения буфера
		while( Serial.available() && i< 99) {
			buffer[i++] = Serial.read();
		}
		// Закрытие массива
		buffer[i++]='\0';
		on1 = 1;
		on2 = 1;
		on3 = 1;
		on4 = 1;
		on5 = 1;
		on6 = 1;
	}
	// Условие если буфер наполнен то разбор буффера
	if(i > 0){
		dist1=atoi(strtok(buffer," "));
		dist2=atoi(strtok(NULL," "));
		dist3=atoi(strtok(NULL," "));
		dist4=atoi(strtok(NULL," "));
		dist5=atoi(strtok(NULL," "));
		dist6=atoi(strtok(NULL," "));
		endtime=atoi(strtok(NULL," "));
    
    stepDist1 = dist1*52;
    stepDist2 = dist2*52;
    stepDist3 = dist3*52;
    stepDist4 = dist4*52;
    stepDist5 = dist5*52;
    stepDist6 = dist6*52;
    
    calcSpeed1 = abs((((stepDist1) - stepper1.currentPosition())/endtime)*2);
    calcSpeed2 = abs((((stepDist2) - stepper2.currentPosition())/endtime)*2);
    calcSpeed3 = abs((((stepDist3) - stepper3.currentPosition())/endtime)*2);
    calcSpeed4 = abs((((stepDist4) - stepper4.currentPosition())/endtime)*2);
    calcSpeed5 = abs((((stepDist5) - stepper5.currentPosition())/endtime)*2);
    calcSpeed6 = abs((((stepDist6) - stepper6.currentPosition())/endtime)*2);
	}

  //Serial.println(calcSpeed1);
  //Serial.println(dist1);
	
	
	// Установки движения
	stepper1.setMaxSpeed(calcSpeed1);
	stepper1.setAcceleration(6000);
	stepper1.moveTo(stepDist1);
	stepper2.setMaxSpeed(calcSpeed2);
	stepper2.setAcceleration(6000);
	stepper2.moveTo(stepDist2);
	stepper3.setMaxSpeed(calcSpeed3);
	stepper3.setAcceleration(6000);
	stepper3.moveTo(stepDist3);
	stepper4.setMaxSpeed(calcSpeed4);
	stepper4.setAcceleration(6000);
	stepper4.moveTo(stepDist4);
	stepper5.setMaxSpeed(calcSpeed5);
	stepper5.setAcceleration(6000);
	stepper5.moveTo(-stepDist5);
	stepper6.setMaxSpeed(calcSpeed6);
	stepper6.setAcceleration(6000);
	stepper6.moveTo(-stepDist6);
	
	// Запуск движения
	stepper1.run();
    stepper2.run();
    stepper3.run();
    stepper4.run();
    stepper5.run();
    stepper6.run();
    
	// Проверка достижения указанной координаты
	if(stepper1.distanceToGo() == 0 && on1 == 1){
		endMove1 = 1;
		on1 = 0;
    }
	if(stepper2.distanceToGo() == 0 && on2 == 1){
		endMove2 = 1;
		on2 = 0;
    }
	if(stepper3.distanceToGo() == 0 && on3 == 1){
		endMove3 = 1;
		on3 = 0;
    }
	if(stepper4.distanceToGo() == 0 && on4 == 1){
		endMove4 = 1;
		on4 = 0;
    }
	if(stepper5.distanceToGo() == 0 && on5 == 1){
		endMove5 = 1;
		on5 = 0;
    }
    if(stepper6.distanceToGo() == 0 && on6 == 1){
		endMove6 = 1;
		on6 = 0;
    }
	
	// Проверка условия конечной координаты
	if(endMove1 == 1 && endMove2 == 1 && endMove3 == 1 && endMove4 == 1 && endMove5 == 1 && endMove6 == 1){
		endMove1 = 0;
		endMove2 = 0;
		endMove3 = 0;
		endMove4 = 0;
		endMove5 = 0;
		endMove6 = 0;
		Serial.println(1);
    }
}
