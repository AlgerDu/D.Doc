CREATE TABLE doc_tree_pattern (
    id              BIGINT,

    code            TEXT            NOT NULL,
    description     TEXT            NOT NULL,
    
    root_tree_id    BIGINT          NOT NULL,

    PRIMARY KEY (id)
);

CREATE TABLE project (
    id              BIGINT,

    name            TEXT            NOT NULL,
    description     TEXT            NOT NULL,
    curr_version_id BIGINT          NOT NULL,

    is_delete       BOOLEAN         NOT NULL,

    PRIMARY KEY (id)
);

CREATE TABLE version (
    id              BIGINT,

    name            TEXT            NOT NULL,
    description     TEXT            NOT NULL,
    project_id      BIGINT          NOT NULL,
    base_version_id BIGINT          NOT NULL,

    pattern_id      BIGINT          NOT NULL,
    root_tree_id    BIGINT          NOT NULL,
    
    is_stable       BOOLEAN         NOT NULL,
    
    is_delete       BOOLEAN         NOT NULL,

    PRIMARY KEY (id)
);

CREATE TABLE doc_tree (
    id              BIGINT,
    parent_id       BIGINT          NOT NULL,
    
    releation_id    BIGINT          NOT NULL,

    doc_bid         BIGINT          NOT NULL,

    start_time      TIMESTAMPTZ     NOT NULL,
    end_time        TIMESTAMPTZ     NOT NULL,

    PRIMARY KEY (id)
);

CREATE TABLE doc (
    id               BIGINT,
    bid              BIGINT          NOT NULL,

    name             TEXT            NOT NULL,
    
    date             JSONB           NOT NULL,
    metadata_tree_id BIGINT          NOT NULL,

    PRIMARY KEY (id)
);