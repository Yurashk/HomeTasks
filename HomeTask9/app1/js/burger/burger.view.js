class BurgerView {
  constructor() {}

  renderBurgerData(data) {
    console.log(data);
  }

  listenSizeChange(cb) {
    //отслеживать нажатие кнопки по иземению размера. И когда юзер нажмет мы вызоваем CB передав в него название ВЫБРАННОГО размера
    cb('large');
  }
  listenStuffingChange(cb){
    cb('beef');
  }
  getViewSize(Arr){
    for(let i=0;i<Arr.length;i++){
      let input = document.createElement('input');
      var textElem = document.createTextNode(Arr[i]);
      input.ClassName="radio";
      input.name="Size";
      input.type="radio";
      input.value=Arr[i];
      input.style.margin=5+"px";
      setSize.appendChild(textElem); 
      setSize.appendChild(input); 
      
      }
  }
  getElements(ElemName){
		let Elarr=document.getElementsByName(ElemName);
		return Elarr;
		
	}
	modifyMenu(e){
		let target=e.target;
		if(getSizes.children.length>=0)
		{
			getSizes.innerHTML = '';
		}
		let result = document.createElement('span');
		result.value=target.value;
		result.innerHTML = target.value;
		getSizes.appendChild(result);
	}
	setSizes(SizeName){
		let size=this.getElements(SizeName);
		for(let i=0;i<size.length;i++){
			size[i].addEventListener('click',this.modifyMenu);
		}
	}
}