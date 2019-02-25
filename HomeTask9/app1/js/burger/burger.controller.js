class BurgerController {
  constructor(model, view) {
    this._model = model;
    this._view = view;
  }

  init() {
    this._model.getBurgerData((data) => {
      this._view.renderBurgerData(data);
    });
    this._getSize();
    this._getStuffing();
  }

  _getSize() {
    this._view.listenSizeChange(sizeName => {
      this._model.setSize(sizeName, data => {
        this._view.renderBurgerData(data);
      });
    });
  }
  _getStuffing(){
    this._view.listenStuffingChange(stuffName =>{
      this._model.setStuffing(stuffName,data =>{
        this._view.renderBurgerData(data);
      });
    });
  }

}