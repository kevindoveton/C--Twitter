import React, { Component } from 'react';
import './style.scss';

class Tweet extends Component {
  render() {
    return (
      <div>
        <p class="tweet-text">Hello, World! This is my first tweet.</p>
        <span class="tweet-username">Username</span>
        <span class="tweet-date">HH:mm DD/MM/YYYY</span>
      </div>
    );
  }
}

export {
  Tweet
};
