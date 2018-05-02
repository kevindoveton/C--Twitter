import * as React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom'
import { Newsfeed } from '../Pages/Newsfeed';

class TwitterRouter extends React.Component {
  // private NotFound = () => ('<h1>404... Not Found</h1>');

  public render() {
    return (
      <BrowserRouter>
        <Switch>
          <Route path='/' component={Newsfeed} />
          {/* <Route path='*' component={this.NotFound} /> */}
        </Switch>
      </BrowserRouter>
    );
  }
}

export default TwitterRouter;
