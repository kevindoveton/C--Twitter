import React, { Component } from 'react';

import './App.scss';
import { Router } from './Components/Router';

class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <h1 className="App-title">Welcome to Twitter</h1>
        </header>
        <main>
          <Router />
        </main>
      </div>
    );
  }
}

export {
  App
};
