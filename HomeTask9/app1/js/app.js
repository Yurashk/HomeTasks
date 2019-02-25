class App {
  constructor() {
    this._burgerModule = new BurgerModule()
  }

  init() {
    this._burgerModule.init();
  }
}

const APP = new App();
APP.init();



// function getData(success, error) {
//   // Send HTTP request to the server ...
//   if (Response) {
//     let data = [];
//     success(data);
//   }
//   if (Error) {
//     let error = {};
//     error(error);
//   }
// }



// function renderData(data) {
//   console.log(data);
// }

// function renderData2(data) {
//   alert(data);
// }

// function renderError(error) {
//   alert(error);
// }



// getData(renderData, renderError);
// getData(renderData2, renderError);