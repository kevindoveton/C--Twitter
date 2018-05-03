import React, { Component } from 'react';
import { Tweet } from '../../Components/Tweet';
import { Link } from 'react-router-dom';

class Newsfeed extends Component {
  constructor(props) {
    super(props);
    this.state = {
      tweets: []
    };
  }

  componentWillMount() {
    fetch('http://localhost:5000/api/newsfeed')
    .then(r => r.json())
    .then(r => {
      this.setState({ tweets: r });
    })
    .catch((e) => {
      console.error('newsfeed: ' + e);
    });
  }

  render() {
    const {tweets} = this.state;
    return (
      <div>
        {tweets.map(t => (
          <Link to={'/tweet/' + t.id} key={t.id}>
            <Tweet key={t.id} tweet={t} user={t.user} link />
          </Link>
        ))}
      </div>
    );
  }
}

export {
  Newsfeed
};