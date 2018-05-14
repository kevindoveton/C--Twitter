import * as React from 'react';
import { Component } from 'react';

import './style.scss';
import { UserIcon } from '../UserIcon';

class NewTweet extends Component {
  constructor(props: any) {
    super(props);
  }

  render() {
    return (
      <div className="new-tweet">
        <UserIcon size={30} />
        <input type="text" className="new-tweet--write" placeholder="What's happening?" />
      </div>
    );
  }
}

export {
  NewTweet
};
