import React, { Component } from 'react';
import './style.scss';

class UserIcon extends Component {
  render() {
    return (
      <span 
        className="user-icon" 
        style={{backgroundImage: 'url(https://placehold.it/100x100/333333)'}}
      ></span>
    )
  }
}

export {
  UserIcon
};