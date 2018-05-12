import * as React from 'react';
import { Component } from 'react';

import './style.scss';
import { UserIcon } from '../UserIcon';

class WhoToFollow extends Component {

  render() {
    return (
      <div className="who-to-follow">
        <div className="who-to-follow--header">
          <h2>Who To Follow</h2>
          <span>Refresh</span>
          <span>View all</span>
        </div>

        <div className="who-to-follow--content">
          <div className="person">
            <span>Followed by Someone and others</span>
            <div>
              <UserIcon />
              <h3>Macroseft</h3>
              <span>@macroseft</span>
              <button>Follow</button>
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
