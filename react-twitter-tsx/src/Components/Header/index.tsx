import * as React from 'react';
import { Component } from 'react';

import './style.scss';
import { UserIcon } from '../UserIcon';

class Header extends Component {
  constructor(props: any) {
    super(props);
  }

  render() {
    return (
      <header className="twityer-header container">
        <div className="header-lhs">
          <span>Home</span>
          <span>Moments</span>
          <span>Notifications</span>
          <span>Messages</span>
        </div>
        <div className="header-c">
          <span>Logo</span>
        </div>
        <div className="header-rhs">
          <input className="header--search" type="text" />
          <UserIcon size={30} />
          <button className="btn btn--primary">Tweet</button>
        </div>
      </header>
    );
  }
}

export {
  Header
};
