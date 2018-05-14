import * as React from 'react';
import { Component } from 'react';

import './style.scss';
import { UserIcon } from '../UserIcon';

class WhoToFollowPerson extends Component<{user: iUser}> {

  render() {
    const u = this.props.user;

    return (
      <div className="who-to-follow-person">
        {/* <span className="person--followed-by">Followed by Someone and others</span> */}
        <div className="person--details">
          <div className="person-details--lhs">
            <UserIcon />
          </div>
          <div className="person-details--rhs">
            <h3 className="person-details--name">{u.name}</h3>
            <span className="person-details--handle">@{u.username}</span>
            <button className="btn btn--outline">Follow</button>
          </div>
        </div>
      </div>
    );
  }

}

export {
  WhoToFollowPerson
};
