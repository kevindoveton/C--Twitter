import * as React from 'react';
import { Component } from 'react';

import './style.scss';
import { UserIcon } from '../../Components/UserIcon';

class UserSummary extends Component {

  render() {
    return (
      <div className="user-summary">
        <span className="header" />
        <div className="content">
          <div className="content-header">
            <UserIcon size={80} />
            <div className="user-details">
            <span className="name">Kevin Doveton</span>
            <span className="handle">@kevindoveton</span>
            </div>
          </div>

          <div className="stats">
            <div className="tweets stat">
              <h4>Tweets</h4>
              <h5>13</h5>
            </div>
            <div className="following stat">
              <h4>Following</h4>
              <h5>75</h5>
            </div>
            <div className="followers stat">
              <h4>Followers</h4>
              <h5>25</h5>
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
