// 1) Определить цену когда ввел правильную память
// 2) Создать аналогичный опрос цвета и в нем определять картинку к соответсвующему цвету(как и цена к памяти)
// ПРИМЕЧАНИЕ: Спрашивать цвет только тогда, когда узанал корректную память(ЦЕНУ)
// 3 * ) Цена зависит не только отпамяти, но и от цвета;
 var memories = [64, 128, 256,512];
 var colors = ['Black' ,'Silver','Blue'];
 var memory;
 var color;
 var img;
 var controller=0;//для проверки на правильность памяти
 var Choise=[];//Массив для хранения атрибутов выбора
 
 
 while(!memory || memory<0 || controller==0)
 {
	var memory = prompt('Memory ??? ');
 
	Choise[0]=memory;
	for (var i = 0; i < memories.length; i++) 
	{
		if (memories[i] === +memory) 
		{
			controller=1;
			Choise[1]=300+i*200;
			break;
		}
	}
	if(controller==0)alert('В наличии память:'+memories);
 }
 controller=0;
 while(!color || controller==0)
 {
	var color = prompt('Which color do u prefer? ');
 
	for (var i = 0; i < colors.length; i++) 
	{
		switch(color)
		{
			case "black":
			case "Black":
				Choise[1]+=20;
				img="Images/black.png";
				controller=1;			
				break;
			case "blue":
			case "Blue":
				Choise[1]+=50;
				img="Images/blue.jpg";
				controller=1;
				break;
			case "silver":
			case "Silver":
				Choise[1]+=70;
				img="Images/Silver.png";
				controller=1;
				break;	
			default:
				//alert( 'Данный цвет отсутствует.' );
				img="";
				break;
		}
		if(controller==1)break;
	}
	if(controller==0)alert( 'Данный цвет отсутствует.' );
	Choise[2]=img;
 } 
 document.write('Размер Паямяти: ' + Choise[0] + 'Gb<br>'+'Цена:' + Choise[1]+'$' + 
 '<br>Цвет:'+'<img height="15px" width="30px" src="'+Choise[2]+'"/>' );
  