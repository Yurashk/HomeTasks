var size = [{
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

var topping = [{
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
class Burger {
  constructor() {
    this.size = size[0];
    this.topping = [];
    this.stuffing = stuffings[0];

  }
  /////////////////FUNC FOR STUFFING NAME////////////////////////////
  setStuffing(stuffingName) {
    let MyStaff = stuffings.find(t => t.name === stuffingName);
    if (MyStaff)
      return this.stuffings = MyStaff;

    console.log('Данная начинка отсутствует!');
  }
  /////////////////FUNC FOR BURGERS SIZE////////////////////////////
  setSize(sizeName) {
    let MySize = size.find(t => t.name === sizeName);
    if (MySize)
      return this.size = MySize;
    console.log('нету размера!');
  }
  //////////////FUNC FOR ADD TOPPING////////////

  setToping(toppingName) {
    let MyTopping = this.topping.find(t => t.name === toppingName);
    if (MyTopping != undefined) return console.log('Данный топпинг уже есть!');
    let Topping = topping.find(Mt => Mt.name === toppingName);
    if (Topping)
      this.topping.push(Topping);
    else return console.log('Данный топпинг отсутствует!')
  }
  /////////////FUNC FOR DELETE TOPPING///////////
  deleteTopping(delToppingName) {
    for(let i=0;i<this.topping.length;i++)
    {
      if(this.topping[i].name==delToppingName)
      this.topping.splice(i,1);
    }

    return console.log('Вы не добавляли данный топинг!');
  }
  ////////////FUNC FOR CALCULATE PRICE//////////
  calcPrice() {
    var price = this.size.price + this.stuffing.price;
    this.topping.forEach(t => price += t.price);
    return price;
  }

}

var burger1 = new Burger();
burger1.setSize('large');
burger1.setStuffing('pork');
console.log(burger1.calcPrice());
burger1.setToping('cheese');
burger1.setToping('tomato');
burger1.setToping('tomato');
burger1.setToping('salad');
burger1.setToping('tomato');
burger1.setToping('фывфывфыв');
burger1.deleteTopping('cheese');
console.log(burger1.calcPrice());
console.log(burger1);