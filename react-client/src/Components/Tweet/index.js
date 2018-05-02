import React, { Component } from 'react';
import './style.scss';
import { UserIcon } from '../UserIcon';

class Tweet extends Component {
  constructor(props) {
    super(props);
    console.log(props);
    const d = props.data;
    this.state = {
      name: d.user.name,
      username: d.user.username,
      text: d.text
    }
  }

  render() {
    const {name, username, text} = this.state;
    return (
      <div className="tweet">
        <div className="tweet-left-column">
          <UserIcon />
        </div>
        <div className="tweet-right-column">
          <div className="tweet-header">
            <span className="tweet-name">{name}</span>
            <span className="tweet-username">@{username}</span>
            <span className="tweet-date">9h</span>
          </div>
          <div className="tweet-body">
            <p className="tweet-text">{text}</p>
          </div>
        </div>
      </div>
    );
  }
}

export {
  Tweet
};
