import * as React from 'react';
import { Component } from 'react';
import TimeAgo from 'javascript-time-ago';
import * as en from 'javascript-time-ago/locale/en';

import { UserIcon } from '../UserIcon';
import './style.scss'; 

TimeAgo.locale(en);
const timeAgo = new TimeAgo('en-US');

class Tweet extends Component<iTweetProps, {key: string}> {
  constructor(props: iTweetProps) {
    super(props);
  }

  formatTime(time: string) {
    if ((Number(new Date()) - 60 * 1000) < Number(new Date(time))) {
      return 'just now';
    } else {
      return timeAgo.format(new Date(time), 'twitter');
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
