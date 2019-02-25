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

}