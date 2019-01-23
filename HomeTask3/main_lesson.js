/*1. Написать функцию которая будет спрашивать у пользователя 2 значения и знак (3 prompt подряд). Если пользователя ввел корректные цифры и корректный знак, то посчитать эти 2 числа с введенным знаком и вывести на экран. Грубо говоря, это калькулятор. Сделать все проверки на NaN, undefined, null.
2. Напиши функцию map(fn, array), которая принимает на вход функцию и массив, и обрабатывает каждый элемент массива этой функцией, возвращая новый массив.
*/

//////////////////// FIRST TASK////////////////////////////////////////////////////////
var calc= function ()
{
	var controller=0;
	var Sign_Values=['/','*','+','-'];
	var error='dividing by zero!';
	while(isNaN(nuber1))
	{
		var nuber1 =+ prompt('first value ? ');
		if(nuber1===null)
		{
			controller=1;
			break;
		}
	}
	controller=0;
	while( isNaN(nuber2))
	{
		var nuber2 =+prompt('second value ? ');
		if(nuber2===null)
		{
			controller=1;
			break;
		}
		
	}
	controller=0;
	while(!sign || controller){
		var sign = prompt('what to do ? ');
		switch(sign){
			case '/':
				if(!nuber2)return error;
				else return nuber1/nuber2;
			case '*':
				return nuber1*nuber2;
			case '+':
				return nuber1+nuber2;
			case '-':
				return nuber1-nuber2;
			default:
				alert( 'Введенный знак отсутствует.' );
				controller=1;
				break;
		}
	}
	
}
document.write("Answer:"+calc()+"<br>");


//////////////////// SECOND TASK////////////////////////////////////////////////////////
var incremFunk=function( a){
	return a+=3;
}
var MyArr=[5,3,5,6,2,3,1,7];
var NewArr=[];
//document.write(incremFunk(b));
var map=function(b,funk){
	for(var i=0;i<MyArr.length;i++){
		
		 NewArr[i]= funk(b[i]);
	}
		return NewArr;
	
	
}
document.write("OldArray:"+MyArr+"<br>NewArray:"+map(MyArr,incremFunk));
