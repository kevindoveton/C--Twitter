import * as React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';

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
          <Link to="/">
            <span>Home</span>
          </Link>
          <Link to="/">
            <span>Moments</span>
          </Link>
          <Link to="/">
            <span>Notifications</span>
          </Link>
          <Link to="/">
            <span>Messages</span>
          </Link>
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
