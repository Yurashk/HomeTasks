
// 1) switch case
// 2) Спрашивать у пользователя память телефона и выводить на экран соответствующую цену к этой памяти
// 3) Спрашивать у пользователя цвет телефона и выводить кратинку соответствующую этому цвету (обратить внимание на то, что пользователь имеет возможность ввести память только тогда, когда выбрал цвет)	
/*var mass=[392,3,1,2,5,1,6,2,3,8,15,9,-2,35,2];

var max,min,sum;
var temp=0;


for(var i=0;i<=mass.length;i++){
	
	for(var j=0;j<=mass.length-i;j++){
		if(mass[j]>mass[j+1]){
			temp=mass[j+1];
			mass[j+1]=mass[j];
			mass[j]=temp;
			
			
		}
		
	}
	
}
document.write("<br>"+mass);
*/
/////////////////////////////////////////
/*
var firsNumb=+prompt("First");
var secondNumb=+prompt("Second");
if(firsNumb>secondNumb)
	console.log("the highest:"+firsNumb);
else if(firsNumb<secondNumb)
	console.log("the highest:"+secondNumb);
else console.log("this two nubs is equal");
*/
//////////////////////////////////////
/*var FlatNumb=+prompt("FlatNub");
var Podezd=0;
if(FlatNumb>=1 && FlatNumb<=20){
	Podezd=1;
}
else if(FlatNumb>=21 && FlatNumb<=48){
	Podezd=2;
}
else if(FlatNumb>=49 && FlatNumb<=90){
	Podezd=3;
}
console.log("Flat is located in podezd #"+Podezd);*/
//////////////////////////
/*var Age=+prompt("Your age is?");
Age=2019-Age;
if(Age>=16){
	alert("Welcome!");
}
else{
	alert("You are so yong for this content,sry:(");
}
///////////////////////////////////////////////////////
*/
/*var experience=+prompt("Your experience is??");
var Nadbavka=0;
switch(true)
{
	case experience>=1 && experience<3:
		Nadbavka=0;
		break;
	case experience>=3 && 10>experience:
		Nadbavka=10;
		break;
	case experience>=10 && 20>experience:
		Nadbavka=20;
		break;
    default:
		Nadbavka="Neverno Zadano";
		break;
}
console.log("Vasha Nadbavka:"+Nadbavka+"%");*/


/*var StepenChisla=function(numb,stepen)
{	var result=1;
	while(stepen){
		
		stepen--;
		result*=numb
	}
	return result;
}
var Number1=prompt("Value??");
var degree=prompt("degree??");
alert(StepenChisla(Number1,degree));*/

var WhichInput = document.querySelectorAll('input');
var areas = document.querySelectorAll('.area');
var ValForWidth=document.getElementById('InputValue');
var ValForHeight=document.getElementById('InputValue2');
ValForHeight.style.display="none";
var controller=1;
var width=0;

var CorrectSize=function(Whichelement,controllerForInput){
	switch(controllerForInput)
	{
			case 1:
			case 2:
				Whichelement.style.width=ValForWidth.value+'px';
				Whichelement.style.height=Whichelement.style.width;
				break;
			case 3:
			case 4:
				Whichelement.style.width=ValForWidth.value+'px';
				Whichelement.style.height=ValForHeight.value+'px';
				break;
			default:
			break;
	}
}
function funcForCheck(e){
	var target = e.target;
	switch(target.value)
		{
			case 'squad':
				controller=1
				ValForHeight.style.display="none";
				
				break;
			case 'circle':
				controller=2;
				ValForHeight.style.display="none";
				break;
			case 'ellips':
				controller=3;
				ValForHeight.style.display="";
				break;
			case 'rectangle':
				controller=4;
				ValForHeight.style.display="";
				break;
			default:
				break;
		}
console.log(controller);
console.log(ValForWidth.value);		
}

var FunctionCreate = function(e) {
	var target = e.target;
	if (!target.classList.contains('area')) {
		return;
	}
	var ElementsColor=colorInput.value;
	
	var el = document.createElement('div');
	el.classList.add('figure');
	
    switch(controller){
		case 1:
			el.classList.add('figure');
			if(ValForWidth.value)CorrectSize(el,1);
			break;
		
		case 2:
			el.classList.add('figure--circle');
			if(ValForWidth.value)CorrectSize(el,1);
			break;
		case 3:
			el.classList.add('figure--circle');
			el.style.width=50+'px';
			if(ValForWidth.value && ValForHeight.value)CorrectSize(el,3);
			
		case 4:
			el.style.width=50+'px';
			if(ValForWidth.value && ValForHeight.value)CorrectSize(el,4);
			break;
		default:
			break;
    }
	el.style.top = e.offsetY + 'px';
	el.style.left = e.offsetX + 'px';
	el.style.backgroundColor = ElementsColor;
	target.appendChild(el);

}
console.log(controller);
for (var i = 0; i < WhichInput.length; i++) {
  WhichInput[i].addEventListener('click', funcForCheck);
}

for (var i = 0; i < areas.length; i++) {
  areas[i].addEventListener('click', FunctionCreate);
}

//WhichInput.addEventListener('click', func);





