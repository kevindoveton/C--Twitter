import * as React from 'react';
import { Component } from 'react';
import { Switch, Route, BrowserRouter } from 'react-router-dom';
import { ModalContainer, ModalRoute } from 'react-router-modal';

import { Newsfeed } from '../../Pages/Newsfeed';
import { SingleTweet } from '../../Pages/Single-Tweet';

import 'react-router-modal/css/react-router-modal.css';

class Router extends Component {
  render() {
    return (
      <div>
        <Switch>
          <Route exact={true} path="/" component={Newsfeed} />
          <Route path="/tweet" component={Newsfeed} />
        </Switch>

        {/* Modals - Note might need something behind it as well */}
        <ModalRoute path="/tweet/:id" parentPath="/" component={SingleTweet} />
        <ModalRoute path="/modal" parentPath="/">Test</ModalRoute>
        {/* This is the element that displays the modals */}
        <ModalContainer />
      </div>
    );
  }
}

export {
  Router
};
