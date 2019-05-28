import React from 'react';
import { connect } from 'dva';

@connect(({ bug }) => ({
    bug
}))

class BugPage extends React.Component {
    componentDidMount() {
        const { dispatch } = this.props;
        dispatch({
            type: 'bug/getBugUrgencys'
        });
    }

    render() {
        const { bug: { list } } = this.props;
        const id = list.length !== 0 ? list[0].Value : 0;
        return (
            <div>
                <span>{id}</span>
            </div>
        );
    }

}
export default BugPage;