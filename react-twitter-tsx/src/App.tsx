import * as React from 'react';
import { Component } from 'react';
// import { ModalContainer } from 'react-router-modal';

import { Router } from './Components/Router';
import { Header } from './Components/Header';

import './App.scss';

function App() {
  return (
    <div className="App">
      <Header />
      <main>
        <Router />
      </main>
    </div>
  );
}

export {App};
