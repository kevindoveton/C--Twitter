import * as React from 'react';
import { Component } from 'react';
import './style.scss';

class UserIcon extends Component<{size?: number, userId?: string}> {
  styles: React.CSSProperties = {};
  constructor(props: any) {
    super(props);
    if (typeof props.userId === 'string') {
      this.styles.backgroundImage = '/img/u/' + props.userId;
    } else {
      this.styles.backgroundImage = 'url(\'https://placehold.it/100x100/333333\')';
    }

    if (typeof props.size === 'number') { 
      this.styles.width = String(props.size) + 'px';
      this.styles.height = String(props.size) + 'px';
    }
  }

  render() {
    return (
      <span 
        className="user-icon" 
        style={this.styles}
      >
        <span className="user-icon-description">icon</span>
      </span>
    );
  }
}

export {
  UserIcon
};
