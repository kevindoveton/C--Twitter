import React, { Component } from 'react';

import './App.css';
import { Newsfeed } from './Pages/Newsfeed';

class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <h1 className="App-title">Welcome to Twitter</h1>
        </header>
        <Newsfeed />
      </div>
    );
  }
}

export default App;
