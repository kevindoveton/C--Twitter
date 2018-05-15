import * as React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';

import './style.scss';
import { UserIcon } from '../../Components/UserIcon';

class UserSummary extends Component<{user: iUser}> {

  constructor(props: any) {
    super(props);
  }

  render() {
    return (
      <div className="user-summary">
        <span className="header" />
        <div className="content">
          <div className="content-header">
            <UserIcon size={80} userId={String(this.props.user.id)} />
            <div className="user-details">
            <Link to={'/user/' + this.props.user.id}>
              <h2 className="name">{this.props.user.name}</h2>
            </Link>
            <span className="handle">@{this.props.user.username}</span>
            </div>
          </div>

          <div className="stats">
            <div className="tweets stat">
              <h4>Tweets</h4>
              <h5>{this.props.user.tweets}</h5>
            </div>
            <div className="following stat">
              <h4>Following</h4>
              <h5>{this.props.user.following}</h5>
            </div>
            <div className="followers stat">
              <h4>Followers</h4>
              <h5>{this.props.user.followers}</h5>
            </div>
          </div>
        </div>
      </div>
    );
  }

}

export {
  UserSummary
};
