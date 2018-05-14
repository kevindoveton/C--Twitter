import * as React from 'react';
import { Component } from 'react';

import './style.scss';
import { UserIcon } from '../UserIcon';

class WhoToFollow extends Component {

  render() {
    return (
      <div className="who-to-follow">
        <div className="who-to-follow--header">
          <h2 className="header--title">Who To Follow</h2>
          <span className="header--link">Refresh</span>
          <span className="header--link">View all</span>
        </div>

        <div className="who-to-follow--content">
          <div className="person">
            {/* <span className="person--followed-by">Followed by Someone and others</span> */}
            <div className="person--details">
              <div className="person-details--lhs">
                <UserIcon />
              </div>
              <div className="person-details--rhs">
                <h3 className="person-details--name">Macroseft</h3>
                <span className="person-details--handle">@macroseft</span>
                <button className="btn btn--outline">Follow</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }

}

export {
  WhoToFollow
};
