import * as React from 'react';
import { Component } from 'react';
import './style.scss';

class UserIcon extends Component {
  render() {
    return (
      <span 
        className="user-icon" 
        style={{backgroundImage: 'url(https://placehold.it/100x100/333333)'}}
      >
        <span className="user-icon-description">icon</span>
      </span>
    );
  }
}

export {
  UserIcon
};
