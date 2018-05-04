import * as React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';

import { Tweet } from '../../Components/Tweet';

class Newsfeed extends Component {
  state: {
    tweets: Array<iNewsfeedRes>
  };
  
  constructor(props: any) {
    super(props);
    this.state = {
      tweets: []
    };
  }

  componentWillMount() {
    fetch(process.env.REACT_APP_API + '/newsfeed/')
    .then(r => r.json())
    .then(r => {
      this.setState({ tweets: r });
    })
    .catch((e) => {
      console.error('newsfeed: ' + e);
    });
  }

  render() {
    const { tweets } = this.state;
    return (
      <div>
        {tweets.map(t => (
          <Link to={'/tweet/' + t.id} key={t.id}>
            <Tweet key={t.id} tweet={t} user={t.user} />
          </Link>
        ))}
      </div>
    );
  }
}

export {
  Newsfeed
};