import React, { Component } from 'react';
import './style.scss';
import { UserIcon } from '../UserIcon';
import TimeAgo from 'javascript-time-ago'
 
// Load locale-specific relative date/time formatting rules.
import en from 'javascript-time-ago/locale/en'
TimeAgo.locale(en)
const timeAgo = new TimeAgo('en-US')

class Tweet extends Component {
  constructor(props) {
    super(props);
    console.log(props);
    const d = props.data;
    this.state = {
      name: d.user.name,
      username: d.user.username,
      text: d.text,
      time: this.formatTime(d.dateTime)
    }
  }

  formatTime(time) {
    if ((new Date() - 60 * 1000) < new Date(time)) {
      return 'just now';
    } else {
      return timeAgo.format(new Date(time), 'twitter')
    }
  }

  render() {
    const {name, username, text, time} = this.state;
    return (
      <div className="tweet">
        <div className="tweet-left-column">
          <UserIcon />
        </div>
        <div className="tweet-right-column">
          <div className="tweet-header">
            <span className="tweet-name">{name}</span>
            <span className="tweet-username">@{username}</span>
            <span className="tweet-date">{time}</span>
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
