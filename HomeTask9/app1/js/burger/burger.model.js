class BurgerModel {
  constructor() {
    this._data = new BurgerData();

    this._size;
    this._stuffing;
    this._toppings = [];
    this._setDefaultBurgerData();
  }

  _setDefaultBurgerData() {
    this._size = this.getSize('small');
    this._stuffing = this.getStuffing('pork');
  }
  setViewBurgerData(cb){
    cb( this._data);
  }
  setViewSize(){
    let arr=this._data.sizes.map(s=>s.name);
    return arr;
  }
///////METHOD TO FIND SIZE IN SIZES////////////
  getSize(name) {
    let size = this._data.sizes.find(s => s.name === name);
    return size;
    // for (let i = 0; i < this._data.sizes.length; i++) {
    //   if (this._data.sizes[i].name === name) {
    //     return this._data.sizes[i];
    //   }
    // }
  }
///////METHOD TO FIND stuffing IN stuffings////////////
  getStuffing(name) {
    let stuffing = this._data.stuffings.find(s => s.name === name);
    return stuffing;
  }
///////METHOD SET SIZE FOR BURGER////////////
  setSize(sizeName, cb) {
    let size = this.getSize(sizeName);
    if (!size) {
      return;
    }
    this._size = size;
    cb(this.getBurgerData());
  }
///////METHOD SET stuffing FOR BURGER////////////
  setStuffing(stuffingName,cb) {
    let stuffing = this.getStuffing(stuffingName);
    if (!stuffing) {
      return;
    }
    this._stuffing = stuffing;
    cb(this.getBurgerData());
  }
  //////METHOD FOR CALC PRICE//////////////////
  _getPrice(){
    return this._stuffing.price+ this._size.price;
  }
  /////METHOD FOR CREATE BURGER////////////////
  getBurgerData(cb) {
    let data = {
      size: this._size,
      stuffing: this._stuffing,
      toppings: this._toppings,
      price:this._getPrice()
    };
    if (!cb) {
      return data;
    }
    cb(data);
  }

}


// let find = function(arr, predicate) {
//   for (let i = 0; i < arr.length; i++) {
//     if (predicate(arr[i])) {
//       return arr[i];
//     }
//   }
// }


// find(arr, s => {return s.name === name})