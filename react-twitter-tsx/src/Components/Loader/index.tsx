import * as React from 'react';
import { Component } from 'react';

import './style.scss';

class Loader extends Component {
  constructor(props: any) {
    super(props);
  }

  render() {
    return (
      <p>Loading</p>
    );
  }
}

export {
  Loader
};
