import * as React from 'react';
import { Component } from 'react';
// import { ModalContainer } from 'react-router-modal';

import { Router } from './Components/Router';

import './App.scss';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1 className="App-title">Welcome to Twityer</h1>
      </header>
      <main>
        <Router />
      </main>
    </div>
  );
}

export {App};
