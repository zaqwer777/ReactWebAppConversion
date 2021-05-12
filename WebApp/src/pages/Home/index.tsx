import * as React from 'react';
import { LocalizeContextProps, Translate, withLocalize } from 'react-localize-redux';
import { Grid } from '@material-ui/core';

interface IProps extends LocalizeContextProps {
  value: string
}

const Home = ({ activeLanguage }: IProps) => (
    <Grid spacing={8}
        container={true}
        direction="row"
        justify="center"
        alignItems="center">
        <div>
            <br />
            <h3>Active Language is {activeLanguage ? activeLanguage.name : ''}</h3>
            <h1><Translate id="greeting" data={{ name: 'App Name' }} /></h1>
        </div>
    </Grid>
);

export default withLocalize(Home);
