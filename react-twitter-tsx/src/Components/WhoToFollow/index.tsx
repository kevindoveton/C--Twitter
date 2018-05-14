import * as React from 'react';
import { Component } from 'react';

import './style.scss';
import { UserIcon } from '../UserIcon';
import { WhoToFollowPerson } from '../WhoToFollowPerson';

class WhoToFollow extends Component {

  render() {
    const user1 = {
      'name': 'Macroseft',
      'username': 'macroseft',
      'id': '0'
    };
    const user2 = {
      'name': 'Merk Zuck',
      'username': 'zuky',
      'id': 'e8pe'
    };

    const users = [user1, user2];

    return (
      <div className="who-to-follow">
        <div className="who-to-follow--header">
          <h2 className="header--title">Who To Follow</h2>
          <span className="header--link">Refresh</span>
          <span className="header--link">View all</span>
        </div>

        <div className="who-to-follow--content">
            {users.map((u, index, arr) => (
              <div className="user">
                <WhoToFollowPerson user={u} key={u.id} />
              </div>
            ))}
        </div>
      </div>
    );
  }

}

export {
  WhoToFollow
};
