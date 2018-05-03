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
    // this.state = {
    //   name: d.user.name,
    //   username: d.user.username,
    //   text: d.text,
    //   time: this.formatTime(d.dateTime)
    // }
  }

  formatTime(time) {
    if ((new Date() - 60 * 1000) < new Date(time)) {
      return 'just now';
    } else {
      return timeAgo.format(new Date(time), 'twitter')
    }
  }

  render() {
    return (
      <div className="tweet">
        <div className="tweet-left-column">
          <UserIcon />
        </div>
        <div className="tweet-right-column">
          <div className="tweet-header">
            <span className="tweet-name">{this.props.user.name}</span>
            <span className="tweet-username">@{this.props.user.username}</span>
            <span className="tweet-date">{this.formatTime(this.props.tweet.dateTime)}</span>
          </div>
          <div className="tweet-body">
            <p className="tweet-text">{this.props.tweet.text}</p>
          </div>
        </div>
      </div>
    );
  }
}

export {
  Tweet
};
