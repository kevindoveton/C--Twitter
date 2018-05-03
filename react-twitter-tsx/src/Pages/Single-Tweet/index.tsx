import * as React from 'react';
import { Component } from 'react';

import './style.scss';

class SingleTweet extends Component {
  constructor(props: any) {
    super(props);
  }

  componentDidMount() {
    console.log(this.props);
  }

  render() {
    return (
      <div className="single-tweet-container">
        <h1>Hello</h1>
      </div>
    );
  }
}

export {
  SingleTweet
};
