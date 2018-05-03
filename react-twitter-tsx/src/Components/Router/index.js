import React, { Component } from 'react';
import { Switch, Route, BrowserRouter } from 'react-router-dom';
import { Newsfeed } from '../../Pages/Newsfeed';
import { SingleTweet } from '../../Pages/Single-Tweet';

class Router extends Component {
  render() {
    return (
      <Switch>
        <Route exact path="/" component={Newsfeed} />
        <Route path="/tweet/" component={SingleTweet} />
      </Switch>
    );
  }
}

export {
  Router
}