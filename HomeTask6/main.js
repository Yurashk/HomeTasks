
var sizes = [{
  name: 'small',
  price: 100
},
{
  name: 'medium',
  price: 150
},
{
  name: 'large',
  price: 200
}
]

var stuffings = [{
  name: 'chicken',
  price: 50
},
{
  name: 'pork',
  price: 70
},
{
  name: 'beef',
  price: 90
}
]

var toppings = [{
  name: 'pepper',
  price: 20
},
{
  name: 'cheese',
  price: 15
},
{
  name: 'tomato',
  price: 10
},
{
  name: 'salad',
  price: 5
}
]
///////////////CLASS BURGER//////////////////////////////
var Burger=function()
{
  this.size=sizes[0];
  this.topping=[];
  this.stuffing=stuffings[0];
  this.topingNumb=0;
}
/////////////////FUNC FOR STUFFING NAME////////////////////////////
Burger.prototype.setStuffing=function(stuffingName)
{
  for(var i=0;i<stuffings.length;i++){
    if(stuffingName===stuffings[i].name)
    {
      this.stuffing=stuffings[i];
      return stuffings[i];
    }
  }
  console.log('Данная начинка отсутствует!');
}
/////////////////FUNC FOR BURGERS SIZE////////////////////////////
Burger.prototype.setSize=function(sizeName)
{
  for(var i=0;i<sizes.length;i++)
  {
    if(sizes[i].name === sizeName)
    {
      this.size=sizes[i];
      return sizes[i];
    }
  }
  console.log('нету размера!');
}
//////////////FUNC FOR CHECK CLONES TOPPING////////////
Burger.prototype.checkClones=function(toppingName){
   if(this.topingNumb>0)
   {
     for(var i=0;i<this.topingNumb;i++){
       if(this.topping[i].name===toppingName){
         return false;
       }  
     }  
   }
   return true;  
   
 }
///////////////FUNC FOR CHECK TOPING//////////////////////
Burger.prototype.AddTopping=function(toppingName)
{
  for(var i=0;i<toppings.length;i++)
  {
    if(toppingName===toppings[i].name)
    {
      if(!this.checkClones(toppingName))
      return console.log('Данный топпинг'+toppingName+' уже добавлен!');;
    
      this.topping[this.topingNumb++]=toppings[i];
      return toppings[i];
    }
  }
  console.log('Нету данного топпинга!');
}

///////////////FUNC FOR ADD TOPING//////////////////////
Burger.prototype.setToping=function(toppingName)
{
  this.AddTopping(toppingName);
}
/////////////FUNC FOR DELETE TOPPING///////////
Burger.prototype.deleteTopping=function(delToppingName)
{
  for(var i=0;i<this.topping.length;i++)
  {
    if(this.topping[i].name===delToppingName)
    {
      this.topping.splice(i,1);
      this.topingNumb--;
      console.log("topping deleted");
      return this.topping;
    }
  }
  console.log('Вы не добавляли данный топинг!');
}
/////////////FUNC FOR CALCULATE PRICE//////////
Burger.prototype.calcPrice=function(){
  var localPrice=0;
  if(this.topping!=0){
    for(var i=0;i<this.topping.length;i++){
      localPrice+=this.topping[i].price;
    }
  }
   return this.size.price + this.stuffing.price+localPrice;
 
}
var burger1=new Burger();
console.log(burger1.calcPrice());
burger1.setSize('large');
burger1.setStuffing('pork');
console.log(burger1.calcPrice());
burger1.setToping('cheese');
burger1.setToping('tomato');
burger1.setToping('salad');
burger1.setToping('pepper');
burger1.setToping('onion');//данного топинга нету
burger1.setToping('cheese');
burger1.deleteTopping('salad');

console.log(burger1.calcPrice());
console.log(burger1);
