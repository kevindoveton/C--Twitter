import * as React from 'react';
import { Component } from 'react';

import './style.scss';
import { UserIcon } from '../../Components/UserIcon';

class TweetModal extends Component<{tweet: iNewsfeedRes}> {
  render() {
    const { tweet } = this.props;
    return (
      <div>
        <div className="single-tweet-header">
          <UserIcon userId={String(tweet.user.id)} />
          <span>{tweet.user.name}</span>
          <span>@{tweet.user.username}</span>
        </div>
        <div className="single-tweet-body">
          <p>{tweet.text}</p>
        </div>
      </div>
    );
  }
}

export {
  TweetModal
};
