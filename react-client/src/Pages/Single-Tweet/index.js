import React, { Component } from 'react';

class SingleTweet extends Component {
  componentDidMount() {
    console.log(this.props)
  }
  render() {
    return (
      <h1>Hello</h1>
    );
  }
}

export {
  SingleTweet
}