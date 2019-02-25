class BurgerModule {
  constructor() {
    this._model = new BurgerModel();
    this._view = new BurgerView();
    this._controller = new BurgerController(this._model, this._view);
  }

  init() {
    this._controller.init();
  }
}