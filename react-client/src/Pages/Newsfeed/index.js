import React, { Component } from 'react';
import { Tweet } from '../../Components/Tweet'
class Newsfeed extends Component {
  render() {
    return (
      <div>
        <Tweet />
        <Tweet />
      </div>
    );
  }
}

export {
  Newsfeed
};