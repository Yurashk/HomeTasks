

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





